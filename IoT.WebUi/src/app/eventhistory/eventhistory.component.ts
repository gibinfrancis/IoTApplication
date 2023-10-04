import { Component, OnInit } from '@angular/core';
import { EventsApiService } from '../services/events-api.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-eventhistory',
  templateUrl: './eventhistory.component.html',
  styleUrls: ['./eventhistory.component.scss']
})
export class EventhistoryComponent implements OnInit {

  receivedData : any;

  constructor(private eventsApiService: EventsApiService, private router: Router, private route: ActivatedRoute) {

    this.route.queryParams.subscribe(params => {
      this.receivedData = params; // Access the data from queryParams
      console.log(this.receivedData);
    });

   }
  
  data: any;
  public lineChartData = [
    { data: [], label: '' },
  ];
  public lineChartLabels = [];

  //on load
  ngOnInit() {    
    //get device list from the service
    this.eventsApiService.listEventHistory(this.receivedData.DeviceId, this.receivedData.EventId).subscribe(response => {
      this.data = response.items;
      console.log(this.data);
      this.lineChartData[0].data = this.data?.map((item: { eventValue: number; }) => (item.eventValue));
      this.lineChartLabels = this.data?.map((item: { updatedOn: Date; }) => (item.updatedOn));
      
    });
  }

  public lineChartOptions = {
    responsive: true,
  };

  public lineChartLegend = true;
  public lineChartType = 'line';
}
