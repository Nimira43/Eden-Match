import { HttpClient } from '@angular/common/http'
import { Component } from '@angular/core'

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'Eden Match'

  constructor(private http: HttpClient) {}
}
