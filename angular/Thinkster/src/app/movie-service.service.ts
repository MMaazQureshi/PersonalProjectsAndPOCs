import { HttpClient } from '@angular/common/http';
import { TaggedTemplateExpr } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { map, pluck, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class MovieServiceService {

  constructor(private httpClient: HttpClient) { }
  ngOnInit(){
    
  }
  GetMovies(){
    return this.httpClient.get('localhost:5000/test.aspx').pipe(
      map((x:any) => x?.data)
      // pluck('data'),
      ,tap(response => {
          console.log(response);
      })
      );
  }
}
