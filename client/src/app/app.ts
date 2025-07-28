import { HttpClient } from '@angular/common/http'
import { Component, inject } from '@angular/core'

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App {
  private http = inject(HttpClient)
  protected title = 'Eden Match'

  constructor(private http: HttpClient) {}
}
