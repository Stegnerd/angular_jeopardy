import {Inject, Injectable} from '@angular/core';
import {Observable} from 'rxjs'
import {HttpClient} from '@angular/common/http'
import {Category} from "../models/category";
import {Question} from "../models/question";

@Injectable({
  providedIn: 'root'
})
export class JeopardyService {

  private readonly apiUrl: string;

  constructor(private client: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.apiUrl = baseUrl;
  }

  question: Question = null;

  /**
   * Gets a list of Categories
   */
  getCategories(): Observable<Category[]> {
     return this.client.get<Category[]>(this.apiUrl + 'jeopardy');
  }

}
