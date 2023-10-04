import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DevicesApiService {

  private apiUrl = 'https://localhost:7163/api/Device'; // Replace with your API endpoint

  constructor(private http: HttpClient) { }

  //list devices
  listDevices(): Observable<any> {
    return this.http.get(this.apiUrl);
  }

}
