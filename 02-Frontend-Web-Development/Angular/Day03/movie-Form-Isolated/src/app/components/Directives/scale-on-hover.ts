// scale-on-hover.directive.ts
import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appScale]', 
  standalone: true, 
})
export class ScaleOnHoverDirective {

  @Input() appScaleOnHover: number = 1.05;

  @Input() transitionDuration: string = '0.3s';

  constructor(private el: ElementRef) {
 
    this.el.nativeElement.style.transition = `transform ${this.transitionDuration} ease-in-out`;
  }


  @HostListener('mouseenter') onMouseEnter() {
    this.scaleElement(this.appScaleOnHover);
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.scaleElement(1); 
  }

  private scaleElement(scale: number) {
    this.el.nativeElement.style.transform = `scale(${scale})`;
  }
}
