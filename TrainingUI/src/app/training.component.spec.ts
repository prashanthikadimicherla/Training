import { TestBed, async } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { TrainingComponent } from './training.component';

describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        TrainingComponent
      ],
    }).compileComponents();
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(TrainingComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'TrainingUI'`, () => {
    const fixture = TestBed.createComponent(TrainingComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('TrainingUI');
  });

  it('should render title in a h1 tag', () => {
    const fixture = TestBed.createComponent(TrainingComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('Welcome to TrainingUI!');
  });
});
