import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { TodoItemDto } from '../dtos/models';

@Injectable({
  providedIn: 'root',
})
export class TodoService {
  apiName = 'Default';

  create = (text: string) =>
    this.restService.request<any, TodoItemDto>({
      method: 'POST',
      url: '/api/app/todo',
      params: { text },
    },
    { apiName: this.apiName });

  delete = (id: number) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/todo/${id}`,
    },
    { apiName: this.apiName });

  getList = () =>
    this.restService.request<any, TodoItemDto[]>({
      method: 'GET',
      url: '/api/app/todo',
    },
    { apiName: this.apiName });

  update = (id: number, item: TodoItemDto) =>
    this.restService.request<any, TodoItemDto>({
      method: 'PUT',
      url: `/api/app/todo/${id}`,
      body: item,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
