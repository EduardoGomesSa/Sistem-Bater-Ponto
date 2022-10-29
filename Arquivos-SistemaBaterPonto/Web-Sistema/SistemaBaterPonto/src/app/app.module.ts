import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './navegacao/footer/footer.component';
import { HomeComponent } from './navegacao/home/home.component';
import { MenuComponent } from './navegacao/menu/menu.component';
import { CadastroFuncionarioComponent } from './cadastros/cadastro-funcionario/cadastro-funcionario.component';
import { CadastroCargoComponent } from './cadastros/cadastro-cargo/cadastro-cargo.component';
import { SobreComponent } from './institucional/sobre/sobre.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HomeComponent,
    MenuComponent,
    CadastroFuncionarioComponent,
    CadastroCargoComponent,
    SobreComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
