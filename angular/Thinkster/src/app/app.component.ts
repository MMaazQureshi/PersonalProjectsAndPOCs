import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MovieServiceService } from './movie-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Thinkster';
  /**
   *
   */
  data:any;
  data$:any;
  constructor(private movieService : MovieServiceService) {
      
  }
  ngOnInit(): void {
    this.data$ =  this.movieService.GetMovies()
    // .subscribe(response =>{
    //   this.data = response;
    // });
  }
}
