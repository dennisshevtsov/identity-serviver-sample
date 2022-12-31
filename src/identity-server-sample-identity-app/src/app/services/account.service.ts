import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { SignInAccountRequestDto  } from '../dtos';
import { SignInAccountResponseDto } from '../dtos';

@Injectable({
  providedIn: 'root',
})
export class AccountService {
  public constructor(private readonly http: HttpClient) { }

  public signin(command: SignInAccountRequestDto) {
    const url = 'api/account/signin';
    const body = JSON.stringify(command);
    const options = {
      headers: {
        'Content-Type': 'application/json',
      },
    };

    return this.http.post<SignInAccountResponseDto>(
      url, body, options);
  }
}