import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { Dolgozo } from '../dolgozo.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  dolgozok: Dolgozo[] = [];

  constructor(private api: ApiService) { }

  ngOnInit(): void {
    this.api.dolgozok().subscribe((d: Dolgozo[]) => {
      this.dolgozok = d;
    })
  }

}
