import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'abptodo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44317',
    redirectUri: baseUrl,
    clientId: 'abptodo_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone abptodo',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44318',
      rootNamespace: 'abptodo',
    },
  },
} as Environment;
