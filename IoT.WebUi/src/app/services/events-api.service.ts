import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class EventsApiService {

  private apiUrl = 'https://localhost:7163/api/Event'; // Replace with your API endpoint

  constructor(private http: HttpClient) { }

  //list Events
  listEvents(deviceId:string): Observable<any> {
    const params = new HttpParams()
                      .set('DeviceId', deviceId);

    return this.http.get(this.apiUrl, { params });
  }

  //list Events
  listEventHistory(deviceId:string, eventId:number): Observable<any> {
    const params = new HttpParams()
                      .set('DeviceId', deviceId)
                      .set('EventId', eventId);

    return this.http.get(this.apiUrl, { params });
  }

}
