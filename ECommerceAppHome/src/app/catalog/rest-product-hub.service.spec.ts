import { TestBed } from '@angular/core/testing';

import { RestProductHubService } from './rest-product-hub.service';

describe('RestProductHubService', () => {
  let service: RestProductHubService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RestProductHubService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
