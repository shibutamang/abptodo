import type { BookType } from '../../enums/book-type.enum';

export interface CreateUpdateBookDto {
  name: string;
  type: BookType;
  publishDate: string;
  price: number;
}
