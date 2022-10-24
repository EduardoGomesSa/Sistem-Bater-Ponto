import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable()
export class FuncionarioService{
    constructor(private http: HttpClient){

    }

    protected UrlFuncionarioService = "https://localhost:7273/";

    AdicionarFuncionario(funcionario : AdicionarFuncionario) : Observable<boolean>{
        return this.http
        .post<boolean>(this.UrlFuncionarioService + "api/CadastroFuncionario/Post", funcionario);
    }
}