import { RoutesService, eLayoutType, PermissionGuard } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application, 
      },
      {
        path: '/books',
        name: 'Books',
        iconClass: 'fas fa-book',
        order: 1, 
        layout: eLayoutType.application, 
        requiredPolicy:'BookStore'
      },
    ]);
  };
}
