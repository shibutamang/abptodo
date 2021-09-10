import type { AuditedEntityDto } from '@abp/ng.core';
import type { BookType } from '../enums/book-type.enum';

export interface BookDto extends AuditedEntityDto<number> {
  name?: string;
  type: BookType;
  publishDate?: string;
  price: number;
}

export interface TodoItemDto {
  id: number;
  text?: string;
}
