import { HttpClient } from '@angular/common/http'
import { Component, inject, OnInit, signal } from '@angular/core'
import { lastValueFrom } from 'rxjs'
import { Nav } from '../layout/nav/nav'
import { AccountService } from '../core/services/account-service'

@Component({
  selector: 'app-root',
  imports: [Nav],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App implements OnInit {
  private accountService = inject(AccountService)
  private http = inject(HttpClient)
  protected title = 'Eden Match'
  protected members = signal<any>([])

  async ngOnInit() {
    this.members.set(await this.getMembers())
  }
  
  setCurrentUser() {
    
  }

  async getMembers() {
    try {
      return lastValueFrom(this.http.get('https://localhost:5001/api/members'))  
    } catch (error) {
      console.log(error)
      throw error
    }    
  }
}
