/**
 * Dolgozo adatai
 */
export class Dolgozo {
    /**
     * Adatbázis azonosító
     */
    public azonosito: Number = 0;

    /**
     * A dolgozó főnökének azonosítója
     */
    public fonok: Number = 0;

    /**
     * email cím
     */
    public email: string = "";

    /**
     * A dolgozó neve
     */
    public nev: string = "";

    /**
     * A beosztás megnevezése
     */
    public beosztas: string = "";

    /**
     * Dolgozó fényképének URL címe
     */
    public kep: string = "";

    /**
     * A dolgozó önéletrajz fájlának URL címe
     */
    public oneletrajz: string = "";

    /**
     * A dolgozó vállalati struktúrán belüli szintje (számított érték)
     */
    public szint = 0;

    /**
     * Törölhető a dolgozó?
     */
    public torolheto = false;

}
