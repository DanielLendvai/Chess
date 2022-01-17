<?php

/**
 * Dolgozó adatai
 */
class Dolgozo {
    public $azonosito = "";
    public $fonok = "";
    public $email = "";
    public $nev = "";
    public $jelszo = "";
    public $beosztas = "";
    public $kep = "";
    public $oneletrajz = "";
    public $szint = 0;
    public $torolheto = false;
}

class DolgozoKezelo
{
    private $db;
    
    function __construct()
    {
        $this->db = new mysqli("localhost", "root", "", "danix");
        if(!$this->db)
            die("ERROR: Could not connect. " . mysqli_connect_error());

        if($this->db->connect_errno)
            die("Failed to connect to MySQL:" . $this->db->connect_error);
    }

    /**
     * Be van jelentkezve a felhasználó?
     * @return bool
     */
    public function loggedIn()
    {
        return isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true;
    }
    
    public function login($email, $pwd)
    {
        $sql = $this->db->prepare("SELECT azonosito, nev, jelszo FROM dolgozok WHERE email = ?");
        if(!$sql)
            die(mysql_error ($db));
        $sql->bind_param("s", $email);
        $sql->execute();
        $sql->store_result();
        $sql->bind_result($id, $name, $dbpwd);
        $res = $sql->fetch() && $pwd === $dbpwd;
        if($res)
        {
            // Password is correct, so start a new session
            session_start();

            // Store data in session variables
            $_SESSION["loggedin"] = true;
            $_SESSION["id"] = $id;
            $_SESSION["email"] = $email;
            $_SESSION["name"] = $name;
        }
        $sql->free_result();
        $sql->close();
        return $res;
    }

    public function userid()
    {
        return $this->loggedIn() ? $_SESSION["id"] : null;
    }

    private $dmap, $feldolgozott, $dolgozok;
    
    private function addDolgozo($d)
    {
        if(isset($this->feldolgozott[$d->azonosito]))
            return;
        array_push($this->dolgozok, $d);
        $this->feldolgozott[$d->azonosito] = true;
        foreach($this->dmap as $id2 => $d2)
            if($d2->fonok == $d->azonosito)
                $this->addDolgozo($d2);
    }

    public function dolgozok($userid)
    {
        $this->dmap = [];
        $sql = $this->db->prepare("SELECT azonosito, fonok, email, nev, beosztas, kep FROM dolgozok");
        $sql->execute();
        $sql->store_result();
        $sql->bind_result($id, $fonok, $email, $nev, $beosztas, $kep);
        while($sql->fetch())
        {
            $d = new Dolgozo();
            $d->azonosito = $id;
            $d->fonok = $fonok;
            $d->email = $email;
            $d->nev = $nev;
            $d->beosztas = $beosztas;
            $d->kep = $kep;
            $d->szint = $d->fonok == 0 ? 0 : $this->dmap[$d->fonok]->szint + 1;
            $d->torolheto = $d->azonosito == $userid || $d->fonok > 0 && $this->dmap[$d->fonok]->torolheto;
            $this->dmap[$id] = $d;
        }
        $sql->free_result();
        $sql->close();

        $this->feldolgozott = [];
        $this->dolgozok = [];
        foreach($this->dmap as $id => $d)
        {
           $this->addDolgozo($d);
        }
        
        return $this->dolgozok;
    }

    public function dolgozo($azonosito)
    {
        $d = new Dolgozo();
        $d->azonosito = $azonosito;
        
        $sql = $this->db->prepare("SELECT fonok, email, nev, beosztas, kep, oneletrajz FROM dolgozok WHERE azonosito = ?");
        $sql->bind_param("i", $azonosito);
        $sql->execute();
        $sql->store_result();
        $sql->bind_result($fonok, $email, $nev, $beosztas, $kep, $oneletrajz);
        if($sql->fetch())
        {
            $d->fonok = $fonok;
            $d->email = $email;
            $d->nev = $nev;
            $d->beosztas = $beosztas;
            $d->kep = $kep;
            $d->oneletrajz = $oneletrajz;
        }
        $sql->free_result();
        $sql->close();
        return $d;
    }
    
    public function felvitel($dolgozo)
    {
        $sql = $this->db->prepare("INSERT INTO dolgozok (fonok, email, jelszo, nev, beosztas) VALUES (?, ?, ?, ?, ?)");
        $sql->bind_param("issss", $dolgozo->fonok, $dolgozo->email, $dolgozo->jelszo, $dolgozo->nev, $dolgozo->beosztas);
        $sql->execute();
        $sql->close();
    }
    
    public function torles($dolgozo)
    {
        $sql = $this->db->prepare("SELECT fonok FROM dolgozok WHERE azonosito = ?");
        if(!$sql)
            die(mysql_error ($db));
        $sql->bind_param("i", $dolgozo);
        $sql->execute();
        $sql->store_result();
        $sql->bind_result($fonok);
        $sql->fetch();
        $sql->free_result();
        $sql->close();

        $beosztottak = [];
        $sql = $this->db->prepare("SELECT azonosito FROM dolgozok WHERE fonok = ?");
        if(!$sql)
            die(mysql_error ($db));
        $sql->bind_param("i", $dolgozo);
        $sql->execute();
        $sql->store_result();
        $sql->bind_result($bid);
        while($sql->fetch())
            array_push($beosztottak, $bid);
        $sql->free_result();
        $sql->close();

        $this->db->autocommit(FALSE);
        try
        {
            $sql = $this->db->prepare("UPDATE dolgozok SET fonok = ? WHERE azonosito = ?");
            if(!$sql)
                die(mysql_error ($db));
            foreach($beosztottak as $b)
            {
                $sql->bind_param("ii", $fonok, $b);
                $sql->execute();
            }
            $sql->close();

            $sql = $this->db->prepare("DELETE FROM dolgozok WHERE azonosito = ?");
            if(!$sql)
                die(mysql_error ($db));
            $sql->bind_param("i", $dolgozo);
            $sql->execute();
            $sql->close();

            $this->db->commit(TRUE);
        }
        catch (Exception $ex)
        {
            $this->db->rollback();
            throw $ex;
        }
    }

    public function modositas($dolgozo)
    {
        $this->db->autocommit(FALSE);
        try
        {
            $sql = $this->db->prepare("UPDATE dolgozok SET email = ?, nev = ?, beosztas = ? WHERE azonosito = ?");
            $sql->bind_param("sssi", $dolgozo->email, $dolgozo->nev, $dolgozo->beosztas, $dolgozo->azonosito);
            $sql->execute();
            $sql->close();

            if(!empty($dolgozo->jelszo))
            {
                $sql = $this->db->prepare("UPDATE dolgozok SET jelszo = ? WHERE azonosito = ?");
                $sql->bind_param("si", $dolgozo->jelszo, $dolgozo->azonosito);
                $sql->execute();
                $sql->close();
            }

            if(!empty($dolgozo->kep))
            {
                $sql = $this->db->prepare("UPDATE dolgozok SET kep = ? WHERE azonosito = ?");
                $sql->bind_param("si", $dolgozo->kep, $dolgozo->azonosito);
                $sql->execute();
                $sql->close();
            }
            
            if(!empty($dolgozo->oneletrajz))
            {
                $sql = $this->db->prepare("UPDATE dolgozok SET oneletrajz = ? WHERE azonosito = ?");
                $sql->bind_param("si", $dolgozo->oneletrajz, $dolgozo->azonosito);
                $sql->execute();
                $sql->close();
            }
            
            $this->db->commit(TRUE);
        }
        catch (Exception $ex)
        {
            $this->db->rollback();
            throw $ex;
        }
    }
}
$manager = new DolgozoKezelo();
