import { Component, OnInit } from '@angular/core';
import {Question} from "../../models/question";
import {JeopardyService} from "../../services/jeopardy.service";

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent implements OnInit {

  constructor(private jeopardyService: JeopardyService) { }

  question: Question = null;

  ngOnInit(): void {
    this.question = this.jeopardyService.question
  }

}
