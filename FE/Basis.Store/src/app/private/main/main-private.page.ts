import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from '../common/navbar-component/navbar-component';

@Component({
  selector: 'app-main-page',
  imports: [
    RouterOutlet,
    NavbarComponent,
  ],
  templateUrl: './main-private.page.html',
  styleUrl: './main-private.page.scss',
  standalone: true
})
export class MainPagePrivate {

}
