import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}; // It store username and password which lend be ableto pass to an ever method.

  constructor() { }

  ngOnInit(): void {
  }
  login(){
    console.log(this.model);
  }

}
