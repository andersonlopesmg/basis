import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-main-page',
  imports: [RouterOutlet],
  templateUrl: './main-public.page.html',
  styleUrl: './main-public.page.scss',
  standalone: true
})
export class MainPagePublic {

}
