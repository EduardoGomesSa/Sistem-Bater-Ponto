import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroCargoComponent } from './cadastros/cadastro-cargo/cadastro-cargo.component';
import { CadastroFuncionarioComponent } from './cadastros/cadastro-funcionario/cadastro-funcionario.component';
import { SobreComponent } from './institucional/sobre/sobre.component';
import { HomeComponent } from './navegacao/home/home.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full'},
  {path: 'home', component: HomeComponent},
  {path: 'funcionario', component: CadastroFuncionarioComponent},
  {path: 'cargo', component: CadastroCargoComponent},
  {path: 'sobre', component: SobreComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: false})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
