import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}; // It store username and password which lend be ableto pass to an ever method.

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
  }
  login(){
    this.authService.login(this.model).subscribe(next => {
      console.log('Logged in successfully');
    }, eror => {
      console.log('Failed to login');
    });
  }

  loggedIn(){
    const token = localStorage.getItem('token');
    return!! token;
  }
  logout(){
    localStorage.removeItem('token');
    console.log('logged out');
  }
}
