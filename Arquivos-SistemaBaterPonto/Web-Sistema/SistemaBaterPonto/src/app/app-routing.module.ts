import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CadastroCargoComponent } from './cadastros/cadastro-cargo/cadastro-cargo.component';
import { CadastroFuncionarioComponent } from './cadastros/cadastro-funcionario/cadastro-funcionario.component';

const routes: Routes = [
  {path: 'funcionario', component: CadastroFuncionarioComponent},
  {path: 'cargo', component: CadastroCargoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: false})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
