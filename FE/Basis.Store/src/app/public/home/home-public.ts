import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home-public.html',
  styleUrl: './home-public.scss',
  standalone: true
})
export class HomePublic {
 constructor(private router: Router) {}

  login(): void {
    this.router.navigate(['/app']);
  }
}
