import { Component, OnInit } from '@angular/core';
import { User } from '../model/user';
import { UserService } from '../service/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.sass'
})
export class AppComponent implements OnInit {

  users : User[] =[];
  title = 'pr1';
  constructor(private userService : UserService){}
  ngOnInit(): void {
    this.userService.getAll().subscribe(data => {
     this.users = data;
    });
  }
  onButtonClick(): void  {
    let user = new User();
    user.email= "test4@gmail.com";
    user.password = "password4";
    this.userService.add(user).subscribe(data =>{
      console.log("saved")
    });
  }

  
}
  
  


