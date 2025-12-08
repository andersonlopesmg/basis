import Tema from '@primeuix/themes/aura'; 
import { ApplicationConfig, provideBrowserGlobalErrorListeners, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';


import { routes } from './app.routes';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { providePrimeNG } from 'primeng/config';
import { provideHttpClient } from '@angular/common/http';
import { provideNgxMask, NgxMaskConfig } from 'ngx-mask';

const maskConfig: Partial<NgxMaskConfig> = {
  thousandSeparator: '.',
  decimalMarker: ',',
  prefix: 'R$ '
};



export const appConfig: ApplicationConfig = {

  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideRouter(routes),
    provideHttpClient(),
    
    provideAnimationsAsync(),
    provideNgxMask(maskConfig),
    providePrimeNG({
      theme:{
        preset: Tema,
        options:{
          prefix: 'p',
          darkModeSelector: 'light',
          size: 'small',
        }
      }
    })
  ]
};
