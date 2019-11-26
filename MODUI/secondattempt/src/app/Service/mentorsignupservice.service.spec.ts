import { TestBed } from '@angular/core/testing';

import { MentorsignupserviceService } from './mentorsignupservice.service';

describe('MentorsignupserviceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MentorsignupserviceService = TestBed.get(MentorsignupserviceService);
    expect(service).toBeTruthy();
  });
});
