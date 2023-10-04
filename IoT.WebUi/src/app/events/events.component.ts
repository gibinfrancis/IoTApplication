import { Component,OnInit } from '@angular/core';
import { DevicesApiService } from '../services/devices-api.service';
import { Router, ActivatedRoute } from '@angular/router';
import { EventsApiService } from '../services/events-api.service';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  receivedData : any;

  constructor(private eventsApiService: EventsApiService, private router: Router, private route: ActivatedRoute) {

    this.route.queryParams.subscribe(params => {
      this.receivedData = params; // Access the data from queryParams
      console.log(this.receivedData);
    });

   }
  
  data: any;

  //on load
  ngOnInit() {    
    //get device list from the service
    this.eventsApiService.listEvents(this.receivedData.data).subscribe(response => {
      this.data = response;
      console.log(this.data);
    });
  }

  
  
  //get event history of the event
  viewDetails(deviceId:string, eventId:number)
  {
    this.router.navigate(['/eventhistory'], {
      queryParams: { DeviceId: deviceId,EventId: eventId },
    });

  }
}
