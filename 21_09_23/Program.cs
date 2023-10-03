using Newtonsoft.Json;

namespace DemoJsonToObject;

public class Program
{
    public static void Main(string[] args)
    {

        // //1 question
        //var xml = @"<EVENT>
        //               <DATA>
        //                 <AA siteKey=""8a52acdd377bc40501377f7366c16bd0"">
        //                   <DD siteKey=""8a52acdd377bc40501377f7366c16bd1"">
        //                      <SMT siteKey=""8a52acdd377bc40501377f7366c26bd8"">
        //                     </SMT>
        //                     <DDStatus siteKey=""8a52acdd377bc40501377f7366c16bd2"">
        //                     </DDStatus>
        //                     <Address id=""{http://www.site.com/rr}address_value_entity"" siteKey=""8a52acdd377bc40501377f7366c26bd3"">
        //                     </Address>
        //                     <Address id=""{http://www.site.com/rr}address_value_entity"" siteKey=""8a52acdd377bc40501377f7366c26bd4"">
        //                       <QQ id=""{http://www.site.com/rr}value_QQ_entity"" siteKey=""8a52acdd377bc40501377f7366c26bd5"">
        //                       </QQ>
        //                       <CC siteKey=""8a52acdd377bc40501377f7366c26bd6"">
        //                         <CC_LAT>asd</CC_LAT>
        //                         <CC_LONG></CC_LONG>
        //                       </CC>
        //                     </Address>
        //                     <Address id=""{http://www.site.com/rr}address_value_entity"" siteKey=""8a52acdd377bc40501377f7366c26bd7"">
        //                       <ZZ>BUSINESS</ZZ>
        //                     </Address>
        //                   </DD>
        //                   <GG siteKey=""8a52acdd377bc40501377f7366c36bd9"">
        //                     <LL>false</LL>
        //                     <ZZ>PPCC</ZZ>
        //                     <Address id=""{http://www.site.com/rr}address_value_entity"" siteKey=""8a52acdd377bc40501377f7366c36bda"">
        //                       <ZZ>HOME</ZZ>
        //                     </Address>
        //                     <Phone id=""{http://www.site.com/rr}phone_value_entity"" siteKey=""8a52acdd377bc40501377f7366c36bdb"">
        //                       <ZZ>HOME</ZZ>
        //                     </Phone>
        //                   </GG>
        //                   <MM siteKey=""8a52acdd377bc40501377f7366c36bdc"">
        //                     <OO siteKey=""8a52acdd377bc40501377f7366c36bdd"">
        //                     </OO>
        //                     <UCRCode id=""{http://www.site.com/rr}er_entity"" siteKey=""8a52acdd377a6eb601377a6f05b501e2"">
        //                     </UCRCode>
        //                   </MM>
        //                 </AA>
        //               </DATA>
        //             </EVENT>";

        // XmlSerializer serializer = new XmlSerializer(typeof(EVENT));
        // using (StringReader reader = new StringReader(xml))
        // {
        //     var data = (EVENT)serializer.Deserialize(reader);
        //     Console.WriteLine(data.DATA.AA.GG.Address.ZZ);
        // }

        // 2 question
        //string xml = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>
        //                    <root testAttr=""testValue"">
        //                      <result>
        //                        <child>data1</child>
        //                        <child>A1343358848.646</child>
        //                        <child>
        //                          <internal>
        //                           <data>one</data>
        //                           <data>two</data>
        //                           <unique>Z1343358848.646</unique>
        //                    </internal>
        //                        </child>
        //                      </result>
        //                    </root>";

        //XmlSerializer serializer = new XmlSerializer(typeof(Root));
        //using (StringReader reader = new StringReader(xml))
        //{
        //    var data = (Root)serializer.Deserialize(reader);
        //    Console.WriteLine(data.TestAttr);
        //}

        // 6 question
        //string xml = @"{""kind"": ""Listing"", ""data"": {""after"": ""t3_16o94ar"", ""dist"": 25, ""modhash"": """", ""geo_filter"": null, ""children"": [{""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_h11301uq"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What is an addiction people might not realize they have?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16o60s8"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.93, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 5645, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 5645, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695269400.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16o60s8"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""krebstar10000"", ""discussion_type"": null, ""num_comments"": 5772, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16o60s8/what_is_an_addiction_people_might_not_realize/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16o60s8/what_is_an_addiction_people_might_not_realize/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695269400.0, ""num_crossposts"": 2, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_6kj7jwou"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What makes being single worth it?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16ogzyi"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.89, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 576, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 576, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695305583.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16ogzyi"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""Redlionroar"", ""discussion_type"": null, ""num_comments"": 1595, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16ogzyi/what_makes_being_single_worth_it/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16ogzyi/what_makes_being_single_worth_it/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695305583.0, ""num_crossposts"": 2, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_s4x3vsts"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What\u2019s actually pretty safe but everyone treats it like it\u2019s way more dangerous than it is?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16nzk2x"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.94, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 8293, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 8293, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695251227.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16nzk2x"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""Thrwwyforrandostuff"", ""discussion_type"": null, ""num_comments"": 8693, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16nzk2x/whats_actually_pretty_safe_but_everyone_treats_it/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16nzk2x/whats_actually_pretty_safe_but_everyone_treats_it/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695251227.0, ""num_crossposts"": 5, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_jg7yzykow"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What tattoo is a red flag?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16odiew"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.87, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 590, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 590, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695296139.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16odiew"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""subliminal_hoe"", ""discussion_type"": null, ""num_comments"": 1269, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16odiew/what_tattoo_is_a_red_flag/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16odiew/what_tattoo_is_a_red_flag/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695296139.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_6edimd12"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""Which sport has the biggest gap in ability between men and women?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16oen5o"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.79, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 459, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 459, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695299367.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16oen5o"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""Klaasiker"", ""discussion_type"": null, ""num_comments"": 1191, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16oen5o/which_sport_has_the_biggest_gap_in_ability/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16oen5o/which_sport_has_the_biggest_gap_in_ability/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695299367.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_6ikh7hd8x"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What is the coldest response to \u201cI miss you\u201d?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16oi85l"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.92, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 235, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 235, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695308596.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16oi85l"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""th3-sil3nc3r"", ""discussion_type"": null, ""num_comments"": 945, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16oi85l/what_is_the_coldest_response_to_i_miss_you/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16oi85l/what_is_the_coldest_response_to_i_miss_you/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695308596.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_uxtvyivx"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""People who have cheated before, why did you do it?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16nsqe3"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.84, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 6661, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 6661, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695234733.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16nsqe3"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""miaah214"", ""discussion_type"": null, ""num_comments"": 4357, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16nsqe3/people_who_have_cheated_before_why_did_you_do_it/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16nsqe3/people_who_have_cheated_before_why_did_you_do_it/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695234733.0, ""num_crossposts"": 6, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_8cpjx1op"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""For your mental health what is something or someone you avoid?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16nxhu8"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.93, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 2000, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 2000, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695246207.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16nxhu8"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""babycakesbenny"", ""discussion_type"": null, ""num_comments"": 3933, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16nxhu8/for_your_mental_health_what_is_something_or/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16nxhu8/for_your_mental_health_what_is_something_or/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695246207.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_t5or9vel"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What is the most useless thing you still have memorized?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16o01z8"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.96, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 1393, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 1393, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": true, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695252551.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16o01z8"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""Seraphicly329"", ""discussion_type"": null, ""num_comments"": 6372, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16o01z8/what_is_the_most_useless_thing_you_still_have/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16o01z8/what_is_the_most_useless_thing_you_still_have/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695252551.0, ""num_crossposts"": 1, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_ivc6i"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What is yours favorite sensation that isn't sex, drugs, or rock n roll ?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16og39o"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.86, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 102, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 102, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695303258.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": true, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16og39o"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""MaxHannibal"", ""discussion_type"": null, ""num_comments"": 695, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16og39o/what_is_yours_favorite_sensation_that_isnt_sex/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16og39o/what_is_yours_favorite_sensation_that_isnt_sex/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695303258.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_13o4x4"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""[Serious] What do you think happened to Malaysia Airlines Flight 370?"", ""link_flair_richtext"": [{""e"": ""text"", ""t"": ""Serious Replies Only""}], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16nswix"", ""quarantine"": false, ""link_flair_text_color"": ""light"", ""upvote_ratio"": 0.91, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 3235, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": ""Serious Replies Only"", ""can_mod_post"": false, ""score"": 3235, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695235140.0, ""link_flair_type"": ""richtext"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""link_flair_template_id"": ""54ea6bda-dcf0-11e2-9548-12313b0c8c59"", ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": ""#99c160"", ""id"": ""16nswix"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""rootea"", ""discussion_type"": null, ""num_comments"": 743, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16nswix/serious_what_do_you_think_happened_to_malaysia/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16nswix/serious_what_do_you_think_happened_to_malaysia/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695235140.0, ""num_crossposts"": 2, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_bjp6yzx5"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What are some serious green flags in guys?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16nxd6i"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.9, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 1839, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 1839, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695245916.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16nxd6i"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""AlbatrossPretend7320"", ""discussion_type"": null, ""num_comments"": 1053, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16nxd6i/what_are_some_serious_green_flags_in_guys/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16nxd6i/what_are_some_serious_green_flags_in_guys/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695245916.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_dtdpgsz2"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""what smells so good but is so bad for you?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16o4avl"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.94, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 544, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 544, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695264161.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16o4avl"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""DryFirefighter294"", ""discussion_type"": null, ""num_comments"": 1488, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16o4avl/what_smells_so_good_but_is_so_bad_for_you/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16o4avl/what_smells_so_good_but_is_so_bad_for_you/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695264161.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_8hnebrgp7"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What are some witty replies to \""Why don't you drink?\""?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16o7msg"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.86, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 284, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 284, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695274890.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16o7msg"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""sarthhcasm"", ""discussion_type"": null, ""num_comments"": 579, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16o7msg/what_are_some_witty_replies_to_why_dont_you_drink/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16o7msg/what_are_some_witty_replies_to_why_dont_you_drink/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695274890.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_g7ejnyone"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""Whats the most fucked up shit you witnessed at school?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16oegjb"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.85, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 73, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 73, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695298851.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": true, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16oegjb"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""Icy_Advantage_7192"", ""discussion_type"": null, ""num_comments"": 166, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16oegjb/whats_the_most_fucked_up_shit_you_witnessed_at/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16oegjb/whats_the_most_fucked_up_shit_you_witnessed_at/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695298851.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_f5vn3lg9"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""If you could make an \""update\"" to the human body such as adding two arms or removing pooping, that would affect all humans present and future, what would you add or remove?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16oa246"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.89, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 139, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 139, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695283639.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16oa246"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""notrinz"", ""discussion_type"": null, ""num_comments"": 600, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16oa246/if_you_could_make_an_update_to_the_human_body/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16oa246/if_you_could_make_an_update_to_the_human_body/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695283639.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_jacite"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What is something people think they hide really well, but everyone around them knows what's going on?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16oe9vw"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.84, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 59, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 59, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695298342.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16oe9vw"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""MustheMartian"", ""discussion_type"": null, ""num_comments"": 166, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16oe9vw/what_is_something_people_think_they_hide_really/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16oe9vw/what_is_something_people_think_they_hide_really/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695298342.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_tn4xqwh0"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What\u2019s the most disgusting thing you have ever done?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16nt4w5"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.93, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 1300, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 1300, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695235713.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16nt4w5"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""Neveragainthanks"", ""discussion_type"": null, ""num_comments"": 1367, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16nt4w5/whats_the_most_disgusting_thing_you_have_ever_done/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16nt4w5/whats_the_most_disgusting_thing_you_have_ever_done/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695235713.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_jldux6dr4"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What are signs someone is single?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16nrknk"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.85, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 1587, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 1587, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695231913.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": true, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16nrknk"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""michaeltheleo"", ""discussion_type"": null, ""num_comments"": 1506, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16nrknk/what_are_signs_someone_is_single/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16nrknk/what_are_signs_someone_is_single/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695231913.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_5wn66z0p"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""How do you confess to a man that you don\u2019t find him attractive?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": true, ""name"": ""t3_16ojdr1"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.73, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 18, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 18, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695311382.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16ojdr1"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""xxxsbrn"", ""discussion_type"": null, ""num_comments"": 122, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16ojdr1/how_do_you_confess_to_a_man_that_you_dont_find/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16ojdr1/how_do_you_confess_to_a_man_that_you_dont_find/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695311382.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_86heneji"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What\u2019s your weird food combo that you like that others don\u2019t?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16o81qx"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.9, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 107, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 107, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""author_cakeday"": true, ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695276263.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16o81qx"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""Sanara93"", ""discussion_type"": null, ""num_comments"": 620, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16o81qx/whats_your_weird_food_combo_that_you_like_that/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16o81qx/whats_your_weird_food_combo_that_you_like_that/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695276263.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_jsfw7fex9"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What is a popular band that you can\u2019t stand?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": true, ""name"": ""t3_16oj52w"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.75, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 18, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 18, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695310794.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16oj52w"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""FrankGehryNuman"", ""discussion_type"": null, ""num_comments"": 411, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16oj52w/what_is_a_popular_band_that_you_cant_stand/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16oj52w/what_is_a_popular_band_that_you_cant_stand/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695310794.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_h11301uq"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""Who, in your serious opinion, is the most evil person living today?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16o4ihk"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.81, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 163, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 163, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695264741.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16o4ihk"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""krebstar10000"", ""discussion_type"": null, ""num_comments"": 444, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16o4ihk/who_in_your_serious_opinion_is_the_most_evil/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16o4ihk/who_in_your_serious_opinion_is_the_most_evil/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695264741.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_5e3kw"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What movie did you have zero expectations going in that you loved?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": true, ""name"": ""t3_16ojyz4"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 1.0, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 15, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 15, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695312769.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16ojyz4"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""resident16"", ""discussion_type"": null, ""num_comments"": 57, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16ojyz4/what_movie_did_you_have_zero_expectations_going/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16ojyz4/what_movie_did_you_have_zero_expectations_going/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695312769.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}, {""kind"": ""t3"", ""data"": {""approved_at_utc"": null, ""subreddit"": ""AskReddit"", ""selftext"": """", ""author_fullname"": ""t2_87ecgt37"", ""saved"": false, ""mod_reason_title"": null, ""gilded"": 0, ""clicked"": false, ""title"": ""What gives you the motivation to get up from your bed every morning?"", ""link_flair_richtext"": [], ""subreddit_name_prefixed"": ""r/AskReddit"", ""hidden"": false, ""pwls"": 6, ""link_flair_css_class"": null, ""downs"": 0, ""top_awarded_type"": null, ""hide_score"": false, ""name"": ""t3_16o94ar"", ""quarantine"": false, ""link_flair_text_color"": ""dark"", ""upvote_ratio"": 0.87, ""author_flair_background_color"": null, ""subreddit_type"": ""public"", ""ups"": 68, ""total_awards_received"": 0, ""media_embed"": {}, ""author_flair_template_id"": null, ""is_original_content"": false, ""user_reports"": [], ""secure_media"": null, ""is_reddit_media_domain"": false, ""is_meta"": false, ""category"": null, ""secure_media_embed"": {}, ""link_flair_text"": null, ""can_mod_post"": false, ""score"": 68, ""approved_by"": null, ""is_created_from_ads_ui"": false, ""author_premium"": false, ""thumbnail"": """", ""edited"": false, ""author_flair_css_class"": null, ""author_flair_richtext"": [], ""gildings"": {}, ""content_categories"": null, ""is_self"": true, ""mod_note"": null, ""created"": 1695280058.0, ""link_flair_type"": ""text"", ""wls"": 6, ""removed_by_category"": null, ""banned_by"": null, ""author_flair_type"": ""text"", ""domain"": ""self.AskReddit"", ""allow_live_comments"": false, ""selftext_html"": null, ""likes"": null, ""suggested_sort"": null, ""banned_at_utc"": null, ""view_count"": null, ""archived"": false, ""no_follow"": false, ""is_crosspostable"": false, ""pinned"": false, ""over_18"": false, ""all_awardings"": [], ""awarders"": [], ""media_only"": false, ""can_gild"": false, ""spoiler"": false, ""locked"": false, ""author_flair_text"": null, ""treatment_tags"": [], ""visited"": false, ""removed_by"": null, ""num_reports"": null, ""distinguished"": null, ""subreddit_id"": ""t5_2qh1i"", ""author_is_blocked"": false, ""mod_reason_by"": null, ""removal_reason"": null, ""link_flair_background_color"": """", ""id"": ""16o94ar"", ""is_robot_indexable"": true, ""report_reasons"": null, ""author"": ""DarkPromo69"", ""discussion_type"": null, ""num_comments"": 336, ""send_replies"": true, ""whitelist_status"": ""all_ads"", ""contest_mode"": false, ""mod_reports"": [], ""author_patreon_flair"": false, ""author_flair_text_color"": null, ""permalink"": ""/r/AskReddit/comments/16o94ar/what_gives_you_the_motivation_to_get_up_from_your/"", ""parent_whitelist_status"": ""all_ads"", ""stickied"": false, ""url"": ""https://www.reddit.com/r/AskReddit/comments/16o94ar/what_gives_you_the_motivation_to_get_up_from_your/"", ""subreddit_subscribers"": 43091926, ""created_utc"": 1695280058.0, ""num_crossposts"": 0, ""media"": null, ""is_video"": false}}], ""before"": null}}";

        //var jsonDes = JsonConvert.DeserializeObject<Child>(xml);
        //Console.WriteLine(jsonDes.data.name);

        //// 3 question
        //string json = @"[
        //    {
        //        ""name"": ""Meowsy"",
        //        ""species"": ""cat"",
        //        ""foods"": {
        //            ""likes"": [""tuna"", ""catnip""],
        //            ""dislikes"": [""ham"", ""zucchini""]
        //        }
        //    },
        //    {
        //        ""name"": ""Barky"",
        //        ""species"": ""dog"",
        //        ""foods"": {
        //            ""likes"": [""bones"", ""carrots""],
        //            ""dislikes"": [""tuna""]
        //        }
        //    },
        //    {
        //        ""name"": ""Purrpaws"",
        //        ""species"": ""cat"",
        //        ""foods"": {
        //            ""likes"": [""mice""],
        //            ""dislikes"": [""cookies""]
        //        }
        //    }
        //]";

        //var data = JsonConvert.DeserializeObject<List<Animal>>(json);

        //foreach (var animal in data)
        //{
        //    Console.WriteLine($"Name: {animal.name}");
        //    Console.WriteLine($"Species: {animal.species}");
        //    Console.WriteLine("Likes: " + string.Join(", ", animal.foods.likes));
        //    Console.WriteLine("Dislikes: " + string.Join(", ", animal.foods.dislikes));
        //    Console.WriteLine();
        //}

        //// 4question
        //string json = @"{ ""speakers"": [
        //                 { ""firstname"": ""Ray"",
        //                  ""lastname"": ""Villalobos"",
        //                  ""category"": ""Front End"",
        //                  ""title"": ""Bootstrap & CSS Preprocessors"",
        //                  ""image"": ""http://barcampdeland.org/images/speaker_rayvillalobos.jpg"",
        //                  ""link"": ""http://iviewsource.com"",
        //                  ""bio"": ""Ray Villalobos is a full-time author and teacher at lynda.com. He is author of the book, Exploring Multimedia for Designers. He has more than 20 years experience in developing and programming multimedia projects. Previously at Entravision Communications, he designed and developed a network of radio station and TV web sites. As a senior producer for Tribune Interactive, he was responsible for designing orlandosentinel.com and for creating immersive multimedia projects and Flash games for the site."",
        //                  ""description"": ""As responsive design continues to take over the web, front-end developers and designers have turned to preprocessors and layout systems that simplify their workflow. Lynda.com staff author Ray Villalobos will talk about using the Bootstrap framework from Twitter to scaffold and fast track your responsive design. He'll talk about how you can use CodeKit and LESS to put together designs in hours instead of days.""
        //                 }
        //                ]}";
        //var data = JsonConvert.DeserializeObject<Root>(json);
        //Console.WriteLine(data.speakers);

        // 5 masala
        string json = @"{ ""speakers"": [
	                        { ""firstname"": ""Ray"",
		                        ""lastname"": ""Villalobos"",
		                        ""category"": ""Front End"",
		                        ""title"": ""Bootstrap & CSS Preprocessors"",
		                        ""image"": ""http://barcampdeland.org/images/speaker_rayvillalobos.jpg"",
		                        ""link"": ""http://iviewsource.com"",
		                        ""bio"": ""Ray Villalobos is a full-time author and teacher at lynda.com. He is author of the book, Exploring Multimedia for Designers. He has more than 20 years experience in developing and programming multimedia projects. Previously at Entravision Communications, he designed and developed a network of radio station and TV web sites. As a senior producer for Tribune Interactive, he was responsible for designing orlandosentinel.com and for creating immersive multimedia projects and Flash games for the site."",
		                        ""description"": ""As responsive design continues to take over the web, front-end developers and designers have turned to preprocessors and layout systems that simplify their workflow. Lynda.com staff author Ray Villalobos will talk about using the Bootstrap framework from Twitter to scaffold and fast track your responsive design. He'll talk about how you can use CodeKit and LESS to put together designs in hours instead of days.""
	                        }
                        ]}";

        var data = JsonConvert.DeserializeObject<Root>(json);
        Console.WriteLine(data.speakers);


    }

    public class Root
    {
        public List<Speaker> speakers { get; set; }
    }

    public class Speaker
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string link { get; set; }
        public string bio { get; set; }
        public string description { get; set; }
    }


    //public class Root
    //{
    //    public List<Speaker> speakers { get; set; }
    //}

    //public class Speaker
    //{
    //    public string firstname { get; set; }
    //    public string lastname { get; set; }
    //    public string category { get; set; }
    //    public string title { get; set; }
    //    public string image { get; set; }
    //    public string link { get; set; }
    //    public string bio { get; set; }
    //    public string description { get; set; }
    //}


    public class Foods
    {
        public List<string> likes { get; set; }
        public List<string> dislikes { get; set; }
    }

    public class Animal
    {
        public string name { get; set; }
        public string species { get; set; }
        public Foods foods { get; set; }
    }



    public class Internal
    {
        public List<string> Data { get; set; }
        public string Unique { get; set; }
    }

    public class Child
    {
        public Internal Internal { get; set; }
    }

    public class Result
    {
        public List<Child> Child { get; set; }
    }

    //public class Root
    //{
    //    public Result Result { get; set; }
    //    public string TestAttr { get; set; }
    //    public string Text { get; set; }
    //}





    public class SMT
    {
        public string SiteKey { get; set; }
    }

    public class DDStatus
    {
        public string SiteKey { get; set; }
    }

    public class Address
    {
        public string Id { get; set; }
        public string SiteKey { get; set; }
        public QQ QQ { get; set; }
        public CC CC { get; set; }
        public string ZZ { get; set; }
        public string Text { get; set; }
    }

    public class QQ
    {
        public string Id { get; set; }
        public string SiteKey { get; set; }
    }

    public class CC
    {
        public object CCLAT { get; set; }
        public object CCLONG { get; set; }
        public string SiteKey { get; set; }
    }

    public class DD
    {
        public SMT SMT { get; set; }
        public DDStatus DDStatus { get; set; }
        public List<Address> Address { get; set; }
        public string SiteKey { get; set; }
        public string Text { get; set; }
    }

    public class Phone
    {
        public string ZZ { get; set; }
        public string Id { get; set; }
        public string SiteKey { get; set; }
        public string Text { get; set; }
    }

    public class GG
    {
        public bool LL { get; set; }
        public string ZZ { get; set; }
        public Address Address { get; set; }
        public Phone Phone { get; set; }
        public string SiteKey { get; set; }
        public string Text { get; set; }
    }

    public class OO
    {
        public string SiteKey { get; set; }
    }

    public class UCRCode
    {
        public string Id { get; set; }
        public string SiteKey { get; set; }
    }

    public class MM
    {
        public OO OO { get; set; }
        public UCRCode UCRCode { get; set; }
        public string SiteKey { get; set; }
    }

    public class AA
    {
        public DD DD { get; set; }
        public GG GG { get; set; }
        public MM MM { get; set; }
        public string SiteKey { get; set; }
        public string Text { get; set; }
    }

    public class DATA
    {
        public AA AA { get; set; }
    }

    public class EVENT
    {
        public DATA DATA { get; set; }
    }

    // -----------------


    //public class Child
    //{
    //    public string kind { get; set; }
    //    public Data data { get; set; }
    //}

    public class Data
    {
        public string after { get; set; }
        public int dist { get; set; }
        public string modhash { get; set; }
        public object geo_filter { get; set; }
        public List<Child> children { get; set; }
        public object before { get; set; }
        public object approved_at_utc { get; set; }
        public string subreddit { get; set; }
        public string selftext { get; set; }
        public string author_fullname { get; set; }
        public bool saved { get; set; }
        public object mod_reason_title { get; set; }
        public int gilded { get; set; }
        public bool clicked { get; set; }
        public string title { get; set; }
        public List<LinkFlairRichtext> link_flair_richtext { get; set; }
        public string subreddit_name_prefixed { get; set; }
        public bool hidden { get; set; }
        public int pwls { get; set; }
        public object link_flair_css_class { get; set; }
        public int downs { get; set; }
        public object top_awarded_type { get; set; }
        public bool hide_score { get; set; }
        public string name { get; set; }
        public bool quarantine { get; set; }
        public string link_flair_text_color { get; set; }
        public double upvote_ratio { get; set; }
        public object author_flair_background_color { get; set; }
        public string subreddit_type { get; set; }
        public int ups { get; set; }
        public int total_awards_received { get; set; }
        public MediaEmbed media_embed { get; set; }
        public object author_flair_template_id { get; set; }
        public bool is_original_content { get; set; }
        public List<object> user_reports { get; set; }
        public object secure_media { get; set; }
        public bool is_reddit_media_domain { get; set; }
        public bool is_meta { get; set; }
        public object category { get; set; }
        public SecureMediaEmbed secure_media_embed { get; set; }
        public string link_flair_text { get; set; }
        public bool can_mod_post { get; set; }
        public int score { get; set; }
        public object approved_by { get; set; }
        public bool is_created_from_ads_ui { get; set; }
        public bool author_premium { get; set; }
        public string thumbnail { get; set; }
        public bool edited { get; set; }
        public object author_flair_css_class { get; set; }
        public List<object> author_flair_richtext { get; set; }
        public Gildings gildings { get; set; }
        public object content_categories { get; set; }
        public bool is_self { get; set; }
        public object mod_note { get; set; }
        public double created { get; set; }
        public string link_flair_type { get; set; }
        public int wls { get; set; }
        public object removed_by_category { get; set; }
        public object banned_by { get; set; }
        public string author_flair_type { get; set; }
        public string domain { get; set; }
        public bool allow_live_comments { get; set; }
        public object selftext_html { get; set; }
        public object likes { get; set; }
        public object suggested_sort { get; set; }
        public object banned_at_utc { get; set; }
        public object view_count { get; set; }
        public bool archived { get; set; }
        public bool no_follow { get; set; }
        public bool is_crosspostable { get; set; }
        public bool pinned { get; set; }
        public bool over_18 { get; set; }
        public List<object> all_awardings { get; set; }
        public List<object> awarders { get; set; }
        public bool media_only { get; set; }
        public bool can_gild { get; set; }
        public bool spoiler { get; set; }
        public bool locked { get; set; }
        public object author_flair_text { get; set; }
        public List<object> treatment_tags { get; set; }
        public bool visited { get; set; }
        public object removed_by { get; set; }
        public object num_reports { get; set; }
        public object distinguished { get; set; }
        public string subreddit_id { get; set; }
        public bool author_is_blocked { get; set; }
        public object mod_reason_by { get; set; }
        public object removal_reason { get; set; }
        public string link_flair_background_color { get; set; }
        public string id { get; set; }
        public bool is_robot_indexable { get; set; }
        public object report_reasons { get; set; }
        public string author { get; set; }
        public object discussion_type { get; set; }
        public int num_comments { get; set; }
        public bool send_replies { get; set; }
        public string whitelist_status { get; set; }
        public bool contest_mode { get; set; }
        public List<object> mod_reports { get; set; }
        public bool author_patreon_flair { get; set; }
        public object author_flair_text_color { get; set; }
        public string permalink { get; set; }
        public string parent_whitelist_status { get; set; }
        public bool stickied { get; set; }
        public string url { get; set; }
        public int subreddit_subscribers { get; set; }
        public double created_utc { get; set; }
        public int num_crossposts { get; set; }
        public object media { get; set; }
        public bool is_video { get; set; }
        public string link_flair_template_id { get; set; }
        public bool? author_cakeday { get; set; }
    }

    public class Gildings
    {
    }

    public class LinkFlairRichtext
    {
        public string e { get; set; }
        public string t { get; set; }
    }

    public class MediaEmbed
    {
    }

    //public class Root
    //{
    //    public string kind { get; set; }
    //    public Data data { get; set; }
    //}

    public class SecureMediaEmbed
    {
    }
}