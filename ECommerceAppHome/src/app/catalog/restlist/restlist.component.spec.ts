import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RestlistComponent } from './restlist.component';

describe('RestlistComponent', () => {
  let component: RestlistComponent;
  let fixture: ComponentFixture<RestlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RestlistComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RestlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
