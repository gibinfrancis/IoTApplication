import { TestBed } from '@angular/core/testing';

import { DevicesApiService } from './devices-api.service';

describe('DevicesApiService', () => {
  let service: DevicesApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DevicesApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
