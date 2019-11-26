import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsersignincomponentComponent } from './usersignincomponent.component';

describe('UsersignincomponentComponent', () => {
  let component: UsersignincomponentComponent;
  let fixture: ComponentFixture<UsersignincomponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsersignincomponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsersignincomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
