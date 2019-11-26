import { Component } from '@angular/core';
import { LoginComponent } from './Component/login/login.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'secondattempt';
  constructor(public service:LoginComponent){}
}
