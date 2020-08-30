import {Question} from "./question";

export interface Category {
  id: number,
  title: string,
  clues_count: number,
  questions: Question[]
}
