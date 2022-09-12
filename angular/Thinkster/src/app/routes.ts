import { Routes } from '@angular/router';
import { FlopListComponent } from './flop-list/flop-list.component';
import { FlopSuggestionComponent } from './flop-suggestion/flop-suggestion.component';
export const routes: Routes = [
    {path:'', redirectTo:'flops', pathMatch:'full'},
    {path:'flops',component: FlopListComponent},
    {path:'suggestions',component: FlopSuggestionComponent},
];