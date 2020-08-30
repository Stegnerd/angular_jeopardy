import { Component, OnInit } from '@angular/core';

import {JeopardyService} from "../../services/jeopardy.service";
import {Category} from "../../models/category";


@Component({
  selector: 'app-categoryselect',
  templateUrl: './categoryselect.component.html',
  styleUrls: ['./categoryselect.component.css']
})
export class CategoryselectComponent implements OnInit {

  constructor(private jeopardyService: JeopardyService) { }

  categories: Category[] = [];

  ngOnInit(): void {
    this.getCategories()
  }

  getCategories(): void {
    this.jeopardyService.getCategories().subscribe((categories) => (this.categories = categories));
  }

  storeData(categoryId: number, questionId: number): void {
    const category = this.categories.find(_ => _.id === categoryId);
    const question = category.questions.find(_ => _.id === questionId);

    this.jeopardyService.question = question;
  }
}
