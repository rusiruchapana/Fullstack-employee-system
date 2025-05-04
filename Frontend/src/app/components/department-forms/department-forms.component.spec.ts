import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentFormsComponent } from './department-forms.component';

describe('DepartmentFormsComponent', () => {
  let component: DepartmentFormsComponent;
  let fixture: ComponentFixture<DepartmentFormsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DepartmentFormsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DepartmentFormsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
