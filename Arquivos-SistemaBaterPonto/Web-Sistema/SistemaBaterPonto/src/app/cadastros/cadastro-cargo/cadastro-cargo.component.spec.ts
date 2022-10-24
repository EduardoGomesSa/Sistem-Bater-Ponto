import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroCargoComponent } from './cadastro-cargo.component';

describe('CadastroCargoComponent', () => {
  let component: CadastroCargoComponent;
  let fixture: ComponentFixture<CadastroCargoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastroCargoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CadastroCargoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
