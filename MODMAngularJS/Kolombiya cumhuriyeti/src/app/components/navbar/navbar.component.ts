import { Component, OnInit, ElementRef } from '@angular/core';
import { ROUTES } from '../sidebar/sidebar.component';
import { Location, LocationStrategy, PathLocationStrategy } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  private listTitles: any[];
  location: Location;
  mobile_menu_visible: number = 0;
  private toggleButton: any;
  private sidebarVisible: boolean = false;

  constructor(location: Location, private element: ElementRef, private router: Router) {
    this.location = location;
  }

  ngOnInit(): void {
    this.listTitles = ROUTES.filter(listTitle => listTitle);
    const navbar: HTMLElement = this.element.nativeElement;
    this.toggleButton = navbar.getElementsByClassName('navbar-toggler')[0];
  }

  

  sidebarOpen(): void {
    const body = document.body;
    setTimeout(() => this.toggleButton.classList.add('toggled'), 500);
    body.classList.add('nav-open');
    this.sidebarVisible = true;
  }

  sidebarClose(): void {
    const body = document.body;
    this.toggleButton.classList.remove('toggled');
    body.classList.remove('nav-open');
    this.sidebarVisible = false;
  }

  sidebarToggle(): void {
    this.sidebarVisible ? this.sidebarClose() : this.sidebarOpen();
  }

  getTitle(): string {
    let title = this.location.prepareExternalUrl(this.location.path()).slice(1);
    const foundTitle = this.listTitles.find(item => item.path === title);
    return foundTitle ? foundTitle.title : 'Dashboard';
  }
  

navigateToLogin() {
  this.router.navigate(['/login']);
}
}
