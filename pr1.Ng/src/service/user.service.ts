import {HttpClient} from "@angular/common/http"
import { User } from "../model/user";
import { Observable } from "rxjs";
import { Injectable } from "@angular/core";

@Injectable({ providedIn : "root"})
export class UserService {

    constructor(private client : HttpClient){}

    getAll() : Observable<User[]> {
        return this.client.get<User[]>("/api/user");
    }
    add(user : User): Observable<any>{
        return this.client.post("/api/user",user);
    }
}