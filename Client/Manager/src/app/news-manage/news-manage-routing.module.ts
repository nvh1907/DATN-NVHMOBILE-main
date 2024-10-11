import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NewsComponent } from './news/news.component';

const routes: Routes = [
  {
    path: '', component: NewsComponent, data: {
      breadcrumb: 'Quản lý tin tức'
    }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class NewsManageRoutingModule { }
