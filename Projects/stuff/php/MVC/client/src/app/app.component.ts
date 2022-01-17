import { Component } from '@angular/core';
import {MainService} from "./main.service";
import {Router} from "@angular/router";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'Dolgozó lista';


    constructor(private _main: MainService, private _router: Router) {
    }

    get isLoggedIn(): boolean
    {
        return this._main.isLoggedIn;
    }

    navigate(name: string): void
    {
//        this._sidenav.close();
        this._router.navigate([name]);
    }

}
