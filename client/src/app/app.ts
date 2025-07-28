import { HttpClient } from '@angular/common/http'
import { Component, inject, OnInit } from '@angular/core'

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App implements OnInit {
  ngOnInit(): void {
      throw new Error('Method not implemented.')
  }
  private http = inject(HttpClient)
  protected title = 'Eden Match'

  
}
