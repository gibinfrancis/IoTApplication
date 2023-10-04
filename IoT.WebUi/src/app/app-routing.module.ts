import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { DevicesComponent } from './devices/devices.component';
import { EventsComponent } from './events/events.component';
import { EventhistoryComponent } from './eventhistory/eventhistory.component';

const routes: Routes = [
  {
    path: '',
    component: AppComponent,
    children: [
      {
        path: '',
        component: DevicesComponent,
      },
      {
        path: 'events',
        component: EventsComponent,
      },
      {
        path: 'eventhistory',
        component: EventhistoryComponent,
      },
    ],
  },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
