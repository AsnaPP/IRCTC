import { Component, Input, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ISearchedTrain } from 'src/app/ISearchedTrain.Interface';
import { SearchDetailsService } from 'src/app/search-details.service';
import { TrainsSearchHttpService } from 'src/app/trains-search-http.service';
import { BookingComponent } from '../booking.component';
import { IValuesSearched } from 'src/app/IValuesSearched.Interface';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.sass']
})
export class SearchResultsComponent implements OnInit {
  searchVal:Array<IValuesSearched>=[]
  subs?:Subscription 
  searchDate:string='';
  from:string=''
  to:string=''
  dateVal:string=''
  coach:string=''

  train:Array<ISearchedTrain>=[]
  constructor(private trainService:TrainsSearchHttpService,private searchService:SearchDetailsService,private router: Router,
    private activatedRoute: ActivatedRoute,private booking:BookingComponent) {
      this.subs=this.searchService.search.subscribe((x:Array<IValuesSearched>) => this.searchVal=x)
    console.log(this.searchVal)
    this.from=String(this.searchVal.map(x=>x.fromVal))
    this.to=String(this.searchVal.map(x=>x.toVal))
    this.dateVal=String(this.searchVal.map(x=>x.dateVal))+'T00:00:00'
    this.coach=String(this.searchVal.map(x=>x.coachVal))
    
  }
  ngOnInit():void
  {
    this.trainService.getTrainBySearch(this.from,
     this.to,this.dateVal,this.coach)
      .subscribe((data:Array<ISearchedTrain>)=>{this.train=data;
      console.log(this.train)})  
  }
  onCoach()
  {
    
  }

}