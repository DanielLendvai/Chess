import { Injectable } from '@angular/core';
import {Dolgozo} from "./dolgozo.model";
import {ApiService} from "./api.service";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class MainService {

    private _dolgozo: Dolgozo = new Dolgozo();

    constructor(private _api: ApiService)
    {
    }

    public get isLoggedIn(): boolean
    {
        return this._dolgozo != null && this._dolgozo.azonosito > 0;
    }

    public get dolgozo(): Dolgozo | undefined
    {
        return this._dolgozo;
    }

    public login(uid: string, pwd: string): void
    {
        this
            ._api.login(uid, pwd)
            .subscribe((d: Dolgozo) => {
                this._dolgozo = d;
            });
    }

    public logoff(): void
    {
        this._api.logoff();
        this._dolgozo = new Dolgozo();
    }

}
