SELECT Articles.Topic, Tags.Name
FROM Articles
LEFT JOIN ArticleTag ON Articles.Id = ArticleTag.ArticleId
LEFT JOIN Tags ON ArticleTag.TagId = Tags.Id