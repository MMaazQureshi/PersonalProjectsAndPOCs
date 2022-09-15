import { Routes } from '@angular/router';
import { FlopListComponent } from './flop-list/flop-list.component';
import { FlopSuggestionComponent } from './flop-suggestion/flop-suggestion.component';
import { AuthGuard } from './guards/auth.guard';
import { LoginComponent } from './login/login.component';
export const routes: Routes = [
  { path: '', redirectTo: 'flops', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  {
    path: 'admin',
    canActivate: [AuthGuard],
    loadChildren: () =>
      import('./modules/admin/admin.module').then((x) => x.AdminModule),
  },
  { path: 'flops', component: FlopListComponent },
  { path: 'suggestions', component: FlopSuggestionComponent },
];
