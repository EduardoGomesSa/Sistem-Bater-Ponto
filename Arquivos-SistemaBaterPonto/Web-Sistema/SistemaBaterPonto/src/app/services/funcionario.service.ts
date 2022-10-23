import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class FuncionarioService{
    constructor(private http: HttpClient){

    }

    protected UrlFuncionarioService = "https://localhost:7273/";
}