using Scopel;
using Scopel.Simple;

var builder = new ScopeBuilder<MainScope>();
var objects = new List<ObjectTemplate> { new HelloWordObject() };
var messages = new List<MessageTemplate> { new HelloWordMessage() };
builder.RunScope(messages, objects);