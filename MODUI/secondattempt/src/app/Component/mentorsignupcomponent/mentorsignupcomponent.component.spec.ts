import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MentorsignupcomponentComponent } from './mentorsignupcomponent.component';

describe('MentorsignupcomponentComponent', () => {
  let component: MentorsignupcomponentComponent;
  let fixture: ComponentFixture<MentorsignupcomponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MentorsignupcomponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MentorsignupcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
