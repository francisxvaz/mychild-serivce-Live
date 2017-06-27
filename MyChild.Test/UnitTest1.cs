using System;
using MyChild.Data.Service;
using MyChild.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MyChild.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddAuthor()
        {
            var authorService = new AuthorService();
            authorService.AddAuthor(new Author
            {
                Name = "Sarita Vaz"
            });
        }

        [TestMethod]
        public void GetAuthor()
        {
            var authorService = new AuthorService();
            var authors = authorService.GetAuthors();

        }

        [TestMethod]
        public void GetBlogs()
        {
            var blogService = new BlogService();
            var authors = blogService.GetAllBlogs();
        }

        [TestMethod]
        public void AddBlog()
        {
            var blogService = new BlogService();
            var blogs = blogService.AddBlog(new Blog
            {

                Header = "I want it right now....",
                Body = "<div class='smile'>\r\n\t\t\t\t\t\t\t\t<h2>Introduction</h2>\r\n\t\t\t\t\t\t\t\t<p> It is common to see children pestering their parents in departmental stores or eateries to\r\n\t\t\t\t\t\t\t\thave something which is forbidden or momentarily delayed. Instant gratification is the\r\n\t\t\t\t\t\t\t\tmantra.'I want it now, I want it right now' is the line which goes into a repeated loop\r\n\t\t\t\t\t\t\t\t(combined with emotions of anger and frustration) until the time the parent breaks the loop\r\n\t\t\t\t\t\t\t\tby either giving in or simply ignoring the loud pleas. Cognitively speaking this child-like\r\n\t\t\t\t\t\t\t\tphenomenon is universal and research has attributed it to the undeveloped prefrontal\r\n\t\t\t\t\t\t\t\tcortex which is unable to regulate emotions or postpone gratification.</p>\r\n\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t<img src = '/app/assets/Images/Blogs/valueEducation.jpg' alt= 'Value education in classrooms versus Juvenile homes.' >\r\n\t\t\t\t\t\t\t\t<span class='courtesy'>Image courtesy - Niral Surin</span></p>\r\n\r\n\r\n\t\t\t\t\t\t\t\t<p> It is however interesting to see, when this vestigial behavior surfaces even in adults. In our\r\n\t\t\t\t\t\t\t\texperience as character educators, the most common refrain from authorities is 'that boy\r\n\t\t\t\t\t\t\t\thas not changed.' While their frustration is understandable, their need for immediate\r\n\t\t\t\t\t\t\t\tresults and gratification is puzzling. The child could have been showing delinquent\r\n\t\t\t\t\t\t\t\ttendencies since a long time and it is almost irrational to expect that these unhealthy\r\n\t\t\t\t\t\t\t\tbehaviors disappear (in all or in part) overnight and be replaced by pro-social ones. Even\r\n\t\t\t\t\t\t\t\tfor a minute if we imagine that such a radical change is possible through some magical\r\n\t\t\t\t\t\t\t\tintervention, most likely the change will not be sustainable.The child inevitable will relapse\r\n\t\t\t\t\t\t\t\tback to the default state, leading to 'it is not working'.</p>\r\n\r\n\t\t\t\t\t\t\t\t<p>No one likes change.Least of all the delinquent child who is accustomed to oddball tactics\r\n\t\t\t\t\t\t\t\tof harming self/ others and taking pleasure in seeing the reactions of those around. One of\r\n\t\t\t\t\t\t\t\tthe likely reasons is that they may have learnt this behavior through observation.To see\r\n\t\t\t\t\t\t\t\tones father get his way by abusing the mother may appear unpleasant and anxious for the\r\n\t\t\t\t\t\t\t\tyoung one.But over a period of time, the growing child learns that might is right and one\r\n\t\t\t\t\t\t\t\tcan dominate others by doing likewise.To see a class mate who is labeled as a failure in\r\n\t\t\t\t\t\t\t\tacademics steal the limelight when she is pulled up by the authorities is another point of\r\n\t\t\t\t\t\t\t\tlearning for the starry eyed teenager.It does not matter if one is in the center-stage for the\r\n\t\t\t\t\t\t\t\twrong reason.It is cool to be a dare devil hero - one who can do, what others only end up\r\n\t\t\t\t\t\t\t\tsecretly wishing in their minds.</p>\r\n\r\n\t\t\t\t\t\t\t\t<p>When such a child is exposed to character education, at first the child is usually delighted.\r\n\t\t\t\t\t\t\t\tThe varied activities makes the child feel for the first time there is something interesting\r\n\t\t\t\t\t\t\t\tbeing discussed rather than mundane subjects like science, math and languages.But\r\n\t\t\t\t\t\t\t\twhen character education shifts gears from the awareness and understand phase to\r\n\t\t\t\t\t\t\t\taction phase, thats when the real challenge comes. The child realizes that s(he) has to do\r\n\t\t\t\t\t\t\t\tsomething and that the world is not going to change.That for most is an unacceptable,\r\n\t\t\t\t\t\t\t\tunjust proposition. Most suddenly get disenchanted with the subject matter and begin to\r\n\t\t\t\t\t\t\t\tfind faults with it.They do their best to either disrupt the class or switch off, as they do in\r\n\t\t\t\t\t\t\t\tother classes.Such disruptions are welcome opportunities for interventions, as these\r\n\t\t\t\t\t\t\t\tmoments give a glimpse of the real individual self rather than the projected ideal self. But\r\n\t\t\t\t\t\t\t\tthe catch is that the results take time and are often unpredictable in direction and\r\n\t\t\t\t\t\t\t\tmagnitude.It could be even dependent on extraneous circumstances which might be\r\n\t\t\t\t\t\t\t\tgoing on in the background of the child’s visible life.Unless the therapist or value educator\r\n\t\t\t\t\t\t\t\tis able to understand and have a multi-pronged strategy to deal with the child's deep\r\n\t\t\t\t\t\t\t\trooted factors for delinquency, it is impossible to uproot the weeds from the good produce.</p>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t<p>The bottom line is that patience is a key to the success of any character education\r\n\t\t\t\t\t\t\t\tprogram. Of course it needs to have clear approach, paradigm and accountability in terms\r\n\t\t\t\t\t\t\t\tof consistency and quality.But to measure in terms of 'how many children got reformed'\r\n\t\t\t\t\t\t\t\tsets the program up for a mad number game. Perhaps the line 'I want it right now...' can\r\n\t\t\t\t\t\t\t\tjust be cut short to 'I want it just right...’ That desire should suffice and be the sweet spot.</p>\r\n\r\n\t\t\t\t\t\t </div>",
                PublishDate = new DateTime(2016, 07, 16),
                SubHeader = "By Alwyn Vaz",
                Author = new Author
                {

                    Name = "Alwyn Vaz"
                }
            });
        }


            [TestMethod]
        public void GetAllBlogs()
        {
            var blogService = new BlogService();
            var blogs = blogService.GetAllBlogs();

        }
    }
}
