using Scopel;
using Scopel.Simple;

var builder = new ScopeBuilder<MainScope>();
var sender = new HelloWordPublisherObject();
var subscriber = new HelloWordSubscriberObject();
builder.BuildScope(new List<ObjectTemplate> { subscriber, sender });
sender.StartSending();