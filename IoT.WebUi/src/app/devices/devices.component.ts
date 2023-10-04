import { Component, OnInit } from '@angular/core';
import { DevicesApiService } from '../services/devices-api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-devices',
  templateUrl: './devices.component.html',
  styleUrls: ['./devices.component.scss']
})
export class DevicesComponent implements OnInit {

  constructor(private devicesApiService: DevicesApiService, private router: Router) { }
  
  data: any;
  
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

    this.router.navigate(['/events'], {
      queryParams: { data: deviceId },
    });

  }
}
