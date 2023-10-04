import { Component, OnInit } from '@angular/core';
import { DevicesApiService } from './services/devices-api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  
  title = 'IoT APplication';

  data: any;

  constructor(private devicesApiService: DevicesApiService) { }

  //on load
  ngOnInit() {
    //get device list from the service
    this.devicesApiService.listDevices().subscribe(response => {
      this.data = response;
      console.log(this.data);
    });
  }

  //get events of the device
  viewDetails(deviceId:string)
  {

  }


}
